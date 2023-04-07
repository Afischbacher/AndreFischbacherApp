import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { InterestsService } from '../services/interests.service';
import { Interests } from '../models/interests';
import { LoadingStatus } from '../components/app-loading/app-loading.component';

@Component({
  selector: 'interests-component',
  templateUrl: './interests.component.html',
  styleUrls: ['./interests.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class InterestsComponent implements OnInit {
  
  private interestsData : Interests[];

  public loadingStatus: LoadingStatus = LoadingStatus.Loading;
  public LoadingStatus : typeof LoadingStatus = LoadingStatus;
 
  public mode = "indeterminate";

  constructor( private interestsService : InterestsService) {}  
  
  public ngOnInit(): void {

    this.interestsService.getInterestsInformation().subscribe(response => {
      
    this.interestsData = response;
      this.loadingStatus = LoadingStatus.Loaded;
    }, error => { 
      
      this.loadingStatus = LoadingStatus.Failed;
      console.log(error);
    });

  }

}
 