import { Component, OnInit } from '@angular/core';
import { fadeAnimation } from '../animations/route-animations';
import { AboutService } from '../services/about.service';
import { About } from '../models/about';
import { faHeartbeat, faWrench, faPaintBrush, faAtom } from '@fortawesome/free-solid-svg-icons';
import { AgeService } from '../services/birthday.service';

@Component({
  selector: 'about-component',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.scss'],
  animations: [fadeAnimation]
})
export class AboutComponent implements OnInit {
  public loading: boolean;
  public aboutData: About[] = [];
  public aboutCardData: About[] = [];
  faHeartbeat = faHeartbeat;
  faWrench = faWrench;
  faPaintBrush = faPaintBrush;
  faAtom = faAtom;
  color = 'primary';
  mode = 'indeterminate';

  constructor(private aboutService: AboutService, private ageService: AgeService) { }

  ngOnInit(): void {
    this.getAboutContents();
  }

  public getAboutContents() {
    this.loading = true;
    this.aboutService.getAboutInformation().subscribe((response: About[]) => {
      
      response = this.interpolateAboutMeContentVariables(response);
      this.aboutData = response;

      this.loading = false;

    }, err => console.log(err));
  }

  private interpolateAboutMeContentVariables(aboutContents: About[]): About[] {
    aboutContents.forEach(aboutContent => {
      const regExpVariableMatchGroups = aboutContent.content.match(/(\[.*?\])/gm);

      if (regExpVariableMatchGroups && regExpVariableMatchGroups.length > 0) {
        regExpVariableMatchGroups.forEach(match => {
          switch (match) {
            case "[age]":
              const currentAgeInYears = this.ageService.getCurrentAge();
              aboutContent.content = aboutContent.content.replace(match, currentAgeInYears);
              break;
          }
        });
      }
    });

    return aboutContents;

  }
}

