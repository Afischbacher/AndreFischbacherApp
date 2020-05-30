var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { ContactBottomSheet } from './contact-bottom-sheet.component';
import { MatListModule } from '@angular/material/list';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatRippleModule } from '@angular/material/core';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
let ContactBottomSheetModule = class ContactBottomSheetModule {
};
ContactBottomSheetModule = __decorate([
    NgModule({
        declarations: [
            ContactBottomSheet
        ],
        imports: [
            CommonModule,
            MatIconModule,
            MatRippleModule,
            FontAwesomeModule,
            MatListModule
        ],
        exports: [ContactBottomSheet]
    })
], ContactBottomSheetModule);
export { ContactBottomSheetModule };
//# sourceMappingURL=contact-bottom-sheet.module.js.map