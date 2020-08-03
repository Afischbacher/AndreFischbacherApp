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
  color = 'primary';
  mode = 'indeterminate';
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

  public getCompanyLogo(companyName: string){
    
    console.log(companyName); // getting called twice? why?

    switch(companyName){

      case "Pano Cap Canada Limited":
        return "../../assets/images/Pano-Cap.png";
      
      case "Funding Innovation Inc.":
        return "../../assets/images/funding-innovation.png"

      case "Bank of Montreal":
        return "../../assets/images/bmo-logo-transparent.png";

      case "Plooto Inc.":
        return "../../assets/images/plooto-logo.png";

      default:
        return "";
    }
  }

  public getCompanyLogoCssClass(companyName: string){
    switch(companyName){

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
} 

