import { Component, OnInit } from '@angular/core';
import { fadeAnimation } from '../animations/route-animations';
import { CareerService } from '../services/career.service';
import { Career } from '../models/career';
import { LoadingStatus } from '../components/app-loading/app-loading.component';

@Component({
  selector: 'career-component',
  templateUrl: './career.component.html',
  styleUrls: ['./career.component.scss'],
  animations: [fadeAnimation]
})
export class CareerComponent implements OnInit {

  public careerContents : Career[] = [];
  public loadingStatus: LoadingStatus;
  public LoadingStatus : typeof LoadingStatus = LoadingStatus;

  constructor(private careerService : CareerService) {
  }

  public ngOnInit(): void {
      this.loadingStatus = LoadingStatus.Loading;
      this.getCareerInfo();
   }

  public getCareerInfo(){

      this.careerService.getCareerInformation().subscribe(career => {
          this.careerContents = career;
          this.loadingStatus = LoadingStatus.Loaded;
        }, error => {
            console.error(error);
            this.loadingStatus = LoadingStatus.Failed;
          });

  }


  public getCompanyLogoCssClass(companyName: string): string {
    switch(companyName){

      case "Pano Cap Canada Limited":
        return "pano-cap-logo";
      
      case "Funding Innovation Inc.":
        return "funding-innovation-logo";

      case "Bank of Montreal":
        return "bmo-logo";

      case "Plooto Inc.":
        return "plooto-logo";

      default:
        return "basic-logo";
    }
  }
} 

