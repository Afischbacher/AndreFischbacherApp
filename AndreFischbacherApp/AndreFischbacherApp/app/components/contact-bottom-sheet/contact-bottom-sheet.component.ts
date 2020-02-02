import {Component} from '@angular/core';
import { MatBottomSheetRef } from '@angular/material';
import { faTwitter, faGithub, faSkype, IconDefinition } from '@fortawesome/free-brands-svg-icons';
@Component({
    selector: "contact-bottom-sheet",
    templateUrl: "./contact-bottom-sheet.component.html",
    styleUrls: ["./contact-bottom-sheet.scss"]
})
export class ContactBottomSheet {

    faTwitter : IconDefinition = faTwitter;
    faGithub : IconDefinition  = faGithub;
    faSkype : IconDefinition  = faSkype;
    constructor(private _bottomSheetRef: MatBottomSheetRef<ContactBottomSheet>) {
        
    }
}