import { Component, AfterViewInit } from '@angular/core';
import { zoomInOut } from './animations/route-animations';
import { SwUpdate } from '@angular/service-worker';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  animations: [zoomInOut]
})
export class AppComponent implements AfterViewInit {

  constructor
    (
      private swUpdate: SwUpdate,
      private snackBar: MatSnackBar
    ) { }

  public ngAfterViewInit(): void {

    if (this.swUpdate.isEnabled) {

      this.swUpdate.available
        .subscribe(() => {

          const snackBar = this.snackBar.open('Would you like to update the app to the latest version ?', 'Yes',
            {
              duration: 10000,
              panelClass: ['light-snackbar','dark-snackbar']
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
