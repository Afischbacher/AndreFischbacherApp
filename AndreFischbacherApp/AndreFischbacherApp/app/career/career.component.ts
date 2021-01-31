import { Component, OnInit } from '@angular/core';
import { fadeAnimation } from '../animations/route-animations';
import { CareerService } from '../services/career.service';
import { Career } from '../models/career';

@Component({
  selector: 'career-component',
  templateUrl: './career.component.html',
  styleUrls: ['./career.component.scss'],
  animations: [fadeAnimation]
})
export class CareerComponent implements OnInit {

  public careerContents : Career[] = [];
  public loading: boolean;
  public color = 'primary';
  public mode = 'indeterminate';

  constructor(private careerService : CareerService) {
  }

  public ngOnInit(): void {
      this.loading = true;
      this.getCareerInfo();
   }

  public getCareerInfo(){

      this.careerService.getCareerInformation().subscribe(career => {
          this.careerContents = career;
          this.loading = false;
        }, error => {
            console.log(error);
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

