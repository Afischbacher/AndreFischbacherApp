var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { AppInfoDialog } from '../app-info-dialog/app-info-dialog.component.';
import { ActivatedRoute, Router } from '@angular/router';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
let AppFooter = class AppFooter {
    constructor(appInfoDialog, activatedRoute, router) {
        this.appInfoDialog = appInfoDialog;
        this.activatedRoute = activatedRoute;
        this.router = router;
        this.unsubscribe$ = new Subject();
    }
    ngOnDestroy() {
        this.unsubscribe$.next();
        this.unsubscribe$.complete();
    }
    ngOnInit() {
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
        });
        appInfoDialog.backdropClick()
            .pipe(takeUntil(this.unsubscribe$))
            .subscribe(() => {
            this.router.navigate(['']);
        });
    }
};
AppFooter = __decorate([
    Component({
        selector: "app-footer",
        templateUrl: "./app-footer.component.html",
        styleUrls: ["./app-footer.scss"]
    }),
    __metadata("design:paramtypes", [MatDialog, ActivatedRoute, Router])
], AppFooter);
export { AppFooter };
//# sourceMappingURL=app-footer.component.js.map