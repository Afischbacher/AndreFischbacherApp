import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import {MatCardModule} from '@angular/material/card';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import { AboutModule } from './about/about.module';
import { AboutComponent } from './about/about.component';
import { HomeComponent } from './home/home.component';
import { HomeModule } from './home/home.module';
import { CareerComponent } from './career/career.component';
import { CareerModule } from './career/career.module';
import { InterestsComponent } from './interests/interests.component';
import { InterestsModule } from './interests/interests.module';
import { ContactMeComponent } from './contact-me/contact-me.component';
import { ContactMeModule } from './contact-me/contact-me.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { AppInfoDialogModule } from './components/app-info-dialog/app-info-dialog.module';

const appRoutes: Routes =
    [
        { path: "home", component: HomeComponent, data: { title: "Andre Fischbacher - Home" } },
        { path: "", component: HomeComponent, data: { title: "Andre Fischbacher - Home" } },
        { path: "about", component: AboutComponent, data: { title: "Andre Fischbacher - About" } },
        { path: "career", component: CareerComponent, data: { title: "Andre Fischbacher - Career" } },
        { path: "interests", component: InterestsComponent, data: { title: "Andre Fischbacher - Interests" } },
        { path: "contact-me", component: ContactMeComponent, data: { title: "Andre Fischbacher - Contact Me" } },
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
        ContactMeModule,
        BrowserModule,
        MatCardModule,
        MatIconModule,
        MatButtonModule,
        BrowserAnimationsModule,
        RouterModule.forRoot(appRoutes, {useHash: true})
    ],
    providers: [{provide: LocationStrategy, useClass: HashLocationStrategy}],
    bootstrap: [AppComponent]
})
export class AppModule { }
