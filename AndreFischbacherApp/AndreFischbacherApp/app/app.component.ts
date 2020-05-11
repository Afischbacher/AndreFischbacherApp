import { Component } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { zoomInOut } from './animations/route-animations';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  animations: [zoomInOut]
})
export class AppComponent {
    
    constructor
    (
      private router : Router,
      private activatedRoute: ActivatedRoute
    )
    {

    }
}
