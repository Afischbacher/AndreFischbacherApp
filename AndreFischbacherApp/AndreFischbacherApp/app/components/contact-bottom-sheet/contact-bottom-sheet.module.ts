import { NgModule } from '@angular/core';
import { ContactBottomSheet } from './contact-bottom-sheet.component';
import { MatListModule } from '@angular/material/list';
import { CommonModule } from '@angular/common';
import { MatRippleModule, MatIconModule } from '@angular/material';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
    declarations: [
        ContactBottomSheet
    ],
    imports: [
        CommonModule,
        MatIconModule,
        MatRippleModule,
        FontAwesomeModule,
        MatListModule
    ],
    exports: [ContactBottomSheet]
})
export class ContactBottomSheetModule { }
