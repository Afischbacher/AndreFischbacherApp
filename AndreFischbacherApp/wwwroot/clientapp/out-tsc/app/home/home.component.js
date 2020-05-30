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
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { ContactBottomSheet } from '../components/contact-bottom-sheet/contact-bottom-sheet.component';
import { NavigationService } from '../services/navigation.service';
let HomeComponent = class HomeComponent {
    constructor(bottomContactSheet, navigationService) {
        this.bottomContactSheet = bottomContactSheet;
        this.navigationService = navigationService;
    }
    openContactSheet() {
        this.navigationService.vibrate([25]);
        this.bottomContactSheet.open(ContactBottomSheet, {});
    }
    vibrate() {
        this.navigationService.vibrate([25]);
    }
};
HomeComponent = __decorate([
    Component({
        selector: 'home-component',
        templateUrl: './home.component.html',
        styleUrls: ['./home.component.scss']
    }),
    __metadata("design:paramtypes", [MatBottomSheet, NavigationService])
], HomeComponent);
export { HomeComponent };
//# sourceMappingURL=home.component.js.map