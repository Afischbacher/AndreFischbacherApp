import { Component, OnInit, OnDestroy } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { AppInfoDialog } from '../app-info-dialog/app-info-dialog.component.';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Observable, Subscribable, Subscription, Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: "app-footer",
    templateUrl: "./app-footer.component.html",
    styleUrls: ["./app-footer.scss"]
})
export class AppFooter implements OnInit, OnDestroy {

    private unsubscribe$ = new Subject<void>();

    constructor(private appInfoDialog: MatDialog, private activatedRoute: ActivatedRoute, private router: Router) { }

    ngOnDestroy(): void {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    ngOnInit(): void {

        this.activatedRoute.queryParams
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(param => {
                if (param['modal']) {
                    switch (param['modal']) {
                        case 'aboutApp':
                            this.openAppInfoDialog();
                            break;
                    }
                }
            });
    }

    openAppInfoDialog() {
        let appInfoDialog = this.appInfoDialog.open(AppInfoDialog, {
            width: '500px',
            closeOnNavigation: true
        })

        appInfoDialog.backdropClick()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
                this.router.navigate(['']);
            });
    }

}