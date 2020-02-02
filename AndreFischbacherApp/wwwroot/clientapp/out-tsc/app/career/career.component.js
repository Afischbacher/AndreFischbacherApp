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
import { CareerService } from '../services/career.service';
var CareerComponent = /** @class */ (function () {
    function CareerComponent(careerService) {
        this.careerService = careerService;
        this.careerContents = [];
        this.color = 'primary';
        this.mode = 'indeterminate';
    }
    CareerComponent.prototype.ngOnInit = function () {
        this.loading = true;
        this.getCareerInfo();
    };
    CareerComponent.prototype.getCareerInfo = function () {
        var _this = this;
        this.careerService.getCareerInformation().subscribe(function (career) {
            _this.careerContents = career;
            _this.loading = false;
        }, function (error) {
            console.log(error);
        });
    };
    CareerComponent = __decorate([
        Component({
            selector: 'career-component',
            templateUrl: './career.component.html',
            styleUrls: ['./career.component.scss'],
            animations: [fadeAnimation]
        }),
        __metadata("design:paramtypes", [CareerService])
    ], CareerComponent);
    return CareerComponent;
}());
export { CareerComponent };
//# sourceMappingURL=career.component.js.map