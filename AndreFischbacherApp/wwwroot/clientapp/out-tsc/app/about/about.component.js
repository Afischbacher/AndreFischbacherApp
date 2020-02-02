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
import { fadeAnimation } from '../animations/route-animations';
import { AboutService } from '../services/about.service';
import { faHeartbeat, faWrench, faPaintBrush, faAtom } from '@fortawesome/free-solid-svg-icons';
import { AgeService } from '../services/birthday.service';
var AboutComponent = /** @class */ (function () {
    function AboutComponent(aboutService, ageService) {
        this.aboutService = aboutService;
        this.ageService = ageService;
        this.aboutData = [];
        this.aboutCardData = [];
        this.faHeartbeat = faHeartbeat;
        this.faWrench = faWrench;
        this.faPaintBrush = faPaintBrush;
        this.faAtom = faAtom;
        this.color = 'primary';
        this.mode = 'indeterminate';
    }
    AboutComponent.prototype.ngOnInit = function () {
        this.getAboutContents();
    };
    AboutComponent.prototype.getAboutContents = function () {
        var _this = this;
        this.loading = true;
        this.aboutService.getAboutInformation().subscribe(function (response) {
            response = _this.interpolateAboutMeContentVariables(response);
            _this.aboutData = response;
            _this.loading = false;
        }, function (err) { return console.log(err); });
    };
    AboutComponent.prototype.interpolateAboutMeContentVariables = function (aboutContents) {
        var _this = this;
        aboutContents.forEach(function (aboutContent) {
            var regExpVariableMatchGroups = aboutContent.content.match(/(\[.*?\])/gm);
            if (regExpVariableMatchGroups && regExpVariableMatchGroups.length > 0) {
                regExpVariableMatchGroups.forEach(function (match) {
                    switch (match) {
                        case "[age]":
                            var currentAgeInYears = _this.ageService.getCurrentAge();
                            aboutContent.content = aboutContent.content.replace(match, currentAgeInYears);
                            break;
                    }
                });
            }
        });
        return aboutContents;
    };
    AboutComponent = __decorate([
        Component({
            selector: 'about-component',
            templateUrl: './about.component.html',
            styleUrls: ['./about.component.scss'],
            animations: [fadeAnimation]
        }),
        __metadata("design:paramtypes", [AboutService, AgeService])
    ], AboutComponent);
    return AboutComponent;
}());
export { AboutComponent };
//# sourceMappingURL=about.component.js.map