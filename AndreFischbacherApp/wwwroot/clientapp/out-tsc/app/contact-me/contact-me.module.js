var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ContactMeComponent } from './contact-me.component';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatBottomSheetModule } from '@angular/material/bottom-sheet';
var ContactMeModule = /** @class */ (function () {
    function ContactMeModule() {
    }
    ContactMeModule = __decorate([
        NgModule({
            declarations: [
                ContactMeComponent
            ],
            imports: [
                RouterModule,
                BrowserModule,
                MatCardModule,
                MatIconModule,
                MatButtonModule,
                BrowserAnimationsModule,
                MatBottomSheetModule
            ],
            providers: [],
            exports: [ContactMeComponent]
        })
    ], ContactMeModule);
    return ContactMeModule;
}());
export { ContactMeModule };
//# sourceMappingURL=contact-me.module.js.map