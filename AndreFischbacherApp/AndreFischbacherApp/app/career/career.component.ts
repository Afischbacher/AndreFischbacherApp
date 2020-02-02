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

    ngOnInit(): void {
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
} 

