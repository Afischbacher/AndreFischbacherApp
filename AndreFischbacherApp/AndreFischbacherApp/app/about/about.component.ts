import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';
import { AboutService } from '../services/about.service';
import { About } from '../models/about';
import { faHeartbeat, faWrench, faPaintBrush, faAtom } from '@fortawesome/free-solid-svg-icons';
import { AgeService } from '../services/age.service';
import { LoadingStatus } from '../components/app-loading/app-loading.component';

@Component({
  selector: 'about-component',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class AboutComponent implements OnInit {

  public loadingStatus: LoadingStatus;
  public aboutData: About[] = [];
  public aboutCardData: About[] = [];
  public LoadingStatus : typeof LoadingStatus = LoadingStatus;

  faHeartbeat = faHeartbeat;
  faWrench = faWrench;
  faPaintBrush = faPaintBrush;
  faAtom = faAtom;
  

  constructor(private aboutService: AboutService, private ageService: AgeService) { }

  ngOnInit(): void {
    this.getAboutContents();
  }

  public getAboutContents() {
    this.loadingStatus = LoadingStatus.Loading;
    this.aboutService.getAboutInformation().subscribe((aboutResponse: About[]) => {
      
      aboutResponse = this.interpolateAboutMeContentVariables(aboutResponse);
      this.aboutData = aboutResponse;

      this.loadingStatus = LoadingStatus.Loaded;

    }, error =>  { 
        this.loadingStatus = LoadingStatus.Failed;
        console.error(error);
    });
  }

  private interpolateAboutMeContentVariables(aboutContents: About[]): About[] {
    aboutContents.forEach(aboutContent => {
      const regExpVariableMatchGroups = aboutContent.content.match(/(\[.*?\])/gm);

      if (regExpVariableMatchGroups && regExpVariableMatchGroups.length > 0) {
        regExpVariableMatchGroups.forEach(match => {
          switch (match) {
            case "[age]":
              const currentAgeInYears = this.ageService.getCurrentAge().toString();
              aboutContent.content = aboutContent.content.replace(match, currentAgeInYears);
              break;
          }
        });
      }
    });

    return aboutContents;

  }
}

