var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { Component } from '@angular/core';
import { fadeAnimation } from '../animations/route-animations';
var ContactMeComponent = /** @class */ (function () {
    function ContactMeComponent() {
    }
    ContactMeComponent = __decorate([
        Component({
            selector: 'contact-me-component',
            templateUrl: './contact-me.component.html',
            styleUrls: ['./contact-me.component.scss'],
            animations: [fadeAnimation]
        })
    ], ContactMeComponent);
    return ContactMeComponent;
}());
export { ContactMeComponent };
//# sourceMappingURL=contact-me.component.js.map