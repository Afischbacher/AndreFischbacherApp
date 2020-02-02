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
import { MatBottomSheetRef } from '@angular/material';
import { faTwitter, faGithub, faSkype } from '@fortawesome/free-brands-svg-icons';
var ContactBottomSheet = /** @class */ (function () {
    function ContactBottomSheet(_bottomSheetRef) {
        this._bottomSheetRef = _bottomSheetRef;
        this.faTwitter = faTwitter;
        this.faGithub = faGithub;
        this.faSkype = faSkype;
    }
    ContactBottomSheet = __decorate([
        Component({
            selector: "contact-bottom-sheet",
            templateUrl: "./contact-bottom-sheet.component.html",
            styleUrls: ["./contact-bottom-sheet.scss"]
        }),
        __metadata("design:paramtypes", [MatBottomSheetRef])
    ], ContactBottomSheet);
    return ContactBottomSheet;
}());
export { ContactBottomSheet };
//# sourceMappingURL=contact-bottom-sheet.component.js.map