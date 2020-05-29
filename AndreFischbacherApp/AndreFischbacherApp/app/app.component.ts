import { Component, AfterViewInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { zoomInOut } from './animations/route-animations';
import { SwUpdate } from '@angular/service-worker';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  animations: [zoomInOut]
})
export class AppComponent implements AfterViewInit {
    
    constructor
    (
      private router : Router,
      private activatedRoute: ActivatedRoute,
      private swUpdate: SwUpdate
    )
    {}

  public ngAfterViewInit(): void {
    if (this.swUpdate.isEnabled) {
      this.swUpdate.available
        .subscribe(() => {
          this.swUpdate
            .activateUpdate()
            .then(() => {
              window.location.reload();
            });
       });
    }
  }
}
