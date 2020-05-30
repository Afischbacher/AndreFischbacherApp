var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CareerComponent } from './career.component';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppToolbarModule } from '../components/toolbar/toolbar.module';
import { CareerService } from '../services/career.service';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
let CareerModule = class CareerModule {
};
CareerModule = __decorate([
    NgModule({
        declarations: [
            CareerComponent
        ],
        imports: [
            BrowserModule,
            AppToolbarModule,
            MatCardModule,
            MatIconModule,
            MatButtonModule,
            BrowserAnimationsModule,
            MatProgressSpinnerModule,
            FontAwesomeModule
        ],
        providers: [CareerService],
        exports: [CareerComponent]
    })
], CareerModule);
export { CareerModule };
//# sourceMappingURL=career.module.js.map