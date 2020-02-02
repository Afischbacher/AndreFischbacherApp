import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CareerComponent } from './career.component';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppToolbarModule } from '../components/toolbar/toolbar.module';
import { CareerService } from '../services/career.service';
import { MatProgressSpinnerModule } from '@angular/material';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';


@NgModule({
    declarations: [
        CareerComponent
    ],
    imports: [
        BrowserModule,
        AppToolbarModule,
        MatCardModule,
        MatIconModule,
        MatButtonModule,
        BrowserAnimationsModule,
        MatProgressSpinnerModule,
        FontAwesomeModule
    ],
    providers: [CareerService],
    exports: [CareerComponent]
})
export class CareerModule { }
