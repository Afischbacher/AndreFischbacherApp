import { Component } from '@angular/core';
import { fadeAnimation } from '../animations/route-animations';

@Component({
  selector: 'contact-me-component',
  templateUrl: './contact-me.component.html',
  styleUrls: ['./contact-me.component.scss'],
  animations: [fadeAnimation]

})
export class ContactMeComponent {
    
}
