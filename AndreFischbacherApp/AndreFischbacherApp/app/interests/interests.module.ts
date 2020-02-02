import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { InterestsComponent } from './interests.component';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { AppToolbarModule } from '../components/toolbar/toolbar.module';
import { InterestsService } from '../services/interests.service';
import { CommonModule } from '@angular/common';
import { MatProgressSpinnerModule } from '@angular/material';


@NgModule({
    declarations: [
        InterestsComponent
    ],
    imports: [
        AppToolbarModule,
        CommonModule,
        BrowserModule,
        MatCardModule,
        MatIconModule,
        MatProgressSpinnerModule,
        MatButtonModule
    ],
    providers: [InterestsService],
    exports: [InterestsComponent]
})
export class InterestsModule { }
