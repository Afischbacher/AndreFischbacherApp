var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatDialogModule } from '@angular/material/dialog';
import { MatRippleModule } from '@angular/material/core';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule } from '@angular/router';
import { AppFooter } from './app-footer.component';
import { AppInfoDialog } from '../app-info-dialog/app-info-dialog.component.';
let AppFooterModule = class AppFooterModule {
};
AppFooterModule = __decorate([
    NgModule({
        declarations: [
            AppFooter
        ],
        imports: [
            MatIconModule,
            RouterModule,
            MatRippleModule,
            MatTooltipModule,
            MatToolbarModule,
            MatDialogModule,
            MatButtonModule
        ],
        entryComponents: [AppInfoDialog],
        providers: [],
        exports: [AppFooter]
    })
], AppFooterModule);
export { AppFooterModule };
//# sourceMappingURL=app-footer.module.js.map