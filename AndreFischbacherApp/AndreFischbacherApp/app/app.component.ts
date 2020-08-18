import { Component, AfterViewInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { zoomInOut } from './animations/route-animations';
import { SwUpdate } from '@angular/service-worker';
import { MatSnackBarModule, MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  animations: [zoomInOut]
})
export class AppComponent implements AfterViewInit {

  constructor
    (
      private router: Router,
      private activatedRoute: ActivatedRoute,
      private swUpdate: SwUpdate,
      private snackBar: MatSnackBar
    ) { }

  public ngAfterViewInit(): void {

    if (this.swUpdate.isEnabled) {

      this.swUpdate.available
        .subscribe(() => {

          let snackBar = this.snackBar.open('Would you like to update the app to the latest version ?', 'Yes',
            {
              duration: 5000,
              panelClass: 'dark-snackbar'
            });

          snackBar.onAction().subscribe(() => {
            this.swUpdate
              .activateUpdate()
              .then(() => {
                window.location.reload();
              });
          });
        });
    }
  }
}
