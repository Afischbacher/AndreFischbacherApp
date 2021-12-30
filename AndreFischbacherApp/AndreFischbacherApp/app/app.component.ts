import { Component, AfterViewInit } from '@angular/core';
import { zoomInOut } from './animations/route-animations';
import { SwUpdate, VersionReadyEvent } from '@angular/service-worker';
import { MatSnackBar } from '@angular/material/snack-bar';
import { filter, map } from 'rxjs/operators';
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
      console.log('Service Worker Available!');
      this.swUpdate.versionUpdates.pipe(
        filter((event): event is VersionReadyEvent => event.type === 'VERSION_READY'),
        map((event: VersionReadyEvent) => {
          
          const snackBar = this.snackBar.open(`Would you like to update the Andre Fischbacher app to the latest version - ${event.latestVersion.hash} ?`, 'Yes',
            {
              duration: 10000,
              panelClass: ['light-snackbar', 'dark-snackbar']
            });

          snackBar.onAction().subscribe(() => {
            this.swUpdate
              .activateUpdate()
              .then(() => {
                window.location.reload();
                console.log('Application Updated!');
              }).catch((error) => console.error(error));
          });
        }));
    }
  }
}
