import { Component } from '@angular/core';
import { MatBottomSheet } from '@angular/material/bottom-sheet';
import { ContactBottomSheet } from '../components/contact-bottom-sheet/contact-bottom-sheet.component';
import { NavigationService } from '../services/navigation.service';

@Component({
    selector: 'home-component',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.scss']
})
export class HomeComponent {

    constructor(private bottomContactSheet: MatBottomSheet, private navigationService: NavigationService) {

    }

    public openContactSheet() {
        this.navigationService.vibrate([25]);
        this.bottomContactSheet.open(ContactBottomSheet, {
            closeOnNavigation: true
        });
    }

    public vibrate() {
        this.navigationService.vibrate([25]);
    }
}

