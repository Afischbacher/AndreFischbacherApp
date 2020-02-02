import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ContactMeComponent } from './contact-me.component';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { RouterModule } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatBottomSheetModule } from '@angular/material/bottom-sheet';

@NgModule({
    declarations: [
        ContactMeComponent
    ],
    imports: [ 
        RouterModule,      
        BrowserModule,
        MatCardModule,
        MatIconModule,
        MatButtonModule,
        BrowserAnimationsModule,
        MatBottomSheetModule
    ],
    providers: [],
    exports: [ContactMeComponent]
})
export class ContactMeModule { }
