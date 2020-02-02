import { Component, OnInit } from '@angular/core';
import { InterestsService } from '../services/interests.service';
import { Interests } from '../models/interests';

@Component({
  selector: 'interests-component',
  templateUrl: './interests.component.html',
  styleUrls: ['./interests.component.scss']
})
export class InterestsComponent implements OnInit {
  
  private interestsData : Interests[];

  public loading: boolean;
  public mode = "indeterminate";

  constructor( private interestsService : InterestsService) {}  
  
  public ngOnInit(): void {
    this.loading = true;
    this.interestsService.getInterestsInformation().subscribe(response => {
      
    this.interestsData = response;
      this.loading = false;
    }, error => console.log(error));

  }


}
