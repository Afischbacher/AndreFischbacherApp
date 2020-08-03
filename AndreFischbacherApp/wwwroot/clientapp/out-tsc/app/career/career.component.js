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
let CareerComponent = class CareerComponent {
    constructor(careerService) {
        this.careerService = careerService;
        this.careerContents = [];
        this.color = 'primary';
        this.mode = 'indeterminate';
    }
    ngOnInit() {
        this.loading = true;
        this.getCareerInfo();
    }
    getCareerInfo() {
        this.careerService.getCareerInformation().subscribe(career => {
            this.careerContents = career;
            this.loading = false;
        }, error => {
            console.log(error);
        });
    }
    getCompanyLogo(companyName) {
        console.log(companyName); // getting called twice? why?
        switch (companyName) {
            case "Pano Cap Canada Limited":
                return "../../assets/images/Pano-Cap.png";
            case "Funding Innovation Inc.":
                return "../../assets/images/funding-innovation.png";
            case "Bank of Montreal":
                return "../../assets/images/bmo-logo-transparent.png";
            case "Plooto Inc.":
                return "../../assets/images/plooto-logo.png";
            default:
                return "";
        }
    }
    getCompanyLogoCssClass(companyName) {
        switch (companyName) {
            case "Pano Cap Canada Limited":
                return "pano-cap-canada";
            case "Funding Innovation Inc.":
                return "funding-innovation";
            case "Bank of Montreal":
                return "bmo-logo";
            case "Plooto Inc.":
                return "plooto-logo";
            default:
                return "basic-logo";
        }
    }
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
export { CareerComponent };
//# sourceMappingURL=career.component.js.map