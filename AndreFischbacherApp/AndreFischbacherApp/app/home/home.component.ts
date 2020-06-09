import { Component, OnInit, OnDestroy } from '@angular/core';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { ContactBottomSheet } from '../components/contact-bottom-sheet/contact-bottom-sheet.component';
import { NavigationService } from '../services/navigation.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';

@Component({
    selector: 'home-component',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit, OnDestroy {

    private unsubscribe$: Subject<void> = new Subject<void>();

    constructor(private bottomContactSheet: MatBottomSheet, private navigationService: NavigationService, private activateRoute: ActivatedRoute, private router: Router) {

    }
    
    ngOnDestroy(): void {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }

    ngOnInit(): void {
       this.activateRoute.queryParams
       .pipe(takeUntil(this.unsubscribe$))
       .subscribe(param =>{
            if (param['sheet']) {
                switch (param['sheet']) {
                    case 'contactMe':
                        this.openContactSheet();
                        break;
                }
            }
        });
    }

    public openContactSheet() {
        this.navigationService.vibrate([25]);
        let bottomSheet = this.bottomContactSheet.open(ContactBottomSheet, {
            closeOnNavigation: true
        });

        bottomSheet.backdropClick()
        .pipe(takeUntil(this.unsubscribe$))
        .subscribe(() => {
            this.router.navigate(['']);
        });
    }

    public vibrate() {
        this.navigationService.vibrate([25]);
    }
}

