var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HomeComponent } from './home.component';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { RouterModule } from '@angular/router';
import { MatRippleModule } from '@angular/material/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatBottomSheetModule } from '@angular/material/bottom-sheet';
import { ContactBottomSheet } from '../components/contact-bottom-sheet/contact-bottom-sheet.component';
import { ContactBottomSheetModule } from '../components/contact-bottom-sheet/contact-bottom-sheet.module';
import { MatToolbarModule } from '@angular/material/toolbar';
import { AppFooter } from '../components/app-footer/app-footer.component';
import { AppFooterModule } from '../components/app-footer/app-footer.module';
import { NavigationService } from '../services/navigation.service';
let HomeModule = class HomeModule {
};
HomeModule = __decorate([
    NgModule({
        declarations: [
            HomeComponent
        ],
        imports: [
            RouterModule,
            BrowserModule,
            MatCardModule,
            MatIconModule,
            MatButtonModule,
            MatToolbarModule,
            MatRippleModule,
            MatBottomSheetModule,
            ContactBottomSheetModule,
            AppFooterModule,
            BrowserAnimationsModule
        ],
        entryComponents: [ContactBottomSheet, AppFooter],
        providers: [NavigationService],
        exports: [HomeComponent]
    })
], HomeModule);
export { HomeModule };
//# sourceMappingURL=home.module.js.map