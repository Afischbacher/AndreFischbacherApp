import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AboutComponent } from './about.component';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { AppToolbarModule } from '../components/toolbar/toolbar.module';
import { AboutService } from '../services/about.service';
import { HttpClientModule } from '@angular/common/http';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { AgeService } from '../services/age.service';
import { AppLoadingModule } from '../components/app-loading/app-loading.module';


@NgModule({
    declarations: [
        AboutComponent
    ],
    imports: [
        BrowserModule,
        HttpClientModule,
        AppToolbarModule,
        AppLoadingModule,
        MatCardModule,
        MatIconModule,
        MatProgressSpinnerModule,
        MatButtonModule,
        FontAwesomeModule

    ],
    providers: [AboutService, AgeService],
    exports: [AboutComponent]
})
export class AboutModule { }
