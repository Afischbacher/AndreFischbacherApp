import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { MatCardModule} from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { AboutModule } from './about/about.module';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { HomeModule } from './home/home.module';
import { CareerComponent } from './career/career.component';
import { CareerModule } from './career/career.module';
import { InterestsComponent } from './interests/interests.component';
import { InterestsModule } from './interests/interests.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { AppInfoDialogModule } from './components/app-info-dialog/app-info-dialog.module';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CommonModule } from "@angular/common";
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';
import { AppInfoDialog } from './components/app-info-dialog/app-info-dialog.component.';
import { MatDialogRef } from '@angular/material/dialog';

const appRoutes: Routes =
    [
        { path: "home", component: HomeComponent, data: { title: "Andre Fischbacher - Home" } },
        { path: "", component: HomeComponent, data: { title: "Andre Fischbacher - Home" } },
        { path: "about", component: AboutComponent, data: { title: "Andre Fischbacher - About" } },
        { path: "career", component: CareerComponent, data: { title: "Andre Fischbacher - Career" } },
        { path: "interests", component: InterestsComponent, data: { title: "Andre Fischbacher - Interests" } },
    ];

@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [       
        AboutModule,
        HomeModule,
        CareerModule,
        AppInfoDialogModule,
        InterestsModule,
        CommonModule,
        BrowserModule,
        MatCardModule,
        MatIconModule,
        MatButtonModule,
        BrowserAnimationsModule,
        RouterModule.forRoot(appRoutes, {useHash: true}),
        FontAwesomeModule,
        ServiceWorkerModule.register('ngsw-worker.js', { enabled: environment.production, registrationStrategy: 'registerImmediately' }),
    ],
    providers: [{provide: LocationStrategy, useClass: HashLocationStrategy}],
    bootstrap: [AppComponent]
})
export class AppModule { }
