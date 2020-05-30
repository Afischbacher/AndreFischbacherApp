var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { MatCardModule } from '@angular/material/card';
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
import { ContactMeComponent } from './contact-me/contact-me.component';
import { ContactMeModule } from './contact-me/contact-me.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { AppInfoDialogModule } from './components/app-info-dialog/app-info-dialog.module';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { CommonModule } from "@angular/common";
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';
const appRoutes = [
    { path: "home", component: HomeComponent, data: { title: "Andre Fischbacher - Home" } },
    { path: "", component: HomeComponent, data: { title: "Andre Fischbacher - Home" } },
    { path: "about", component: AboutComponent, data: { title: "Andre Fischbacher - About" } },
    { path: "career", component: CareerComponent, data: { title: "Andre Fischbacher - Career" } },
    { path: "interests", component: InterestsComponent, data: { title: "Andre Fischbacher - Interests" } },
    { path: "contact-me", component: ContactMeComponent, data: { title: "Andre Fischbacher - Contact Me" } },
];
let AppModule = class AppModule {
};
AppModule = __decorate([
    NgModule({
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
            ContactMeModule,
            BrowserModule,
            MatCardModule,
            MatIconModule,
            MatButtonModule,
            BrowserAnimationsModule,
            RouterModule.forRoot(appRoutes, { useHash: true }),
            FontAwesomeModule,
            ServiceWorkerModule.register('ngsw-worker.js', { enabled: environment.production, registrationStrategy: 'registerImmediately' }),
        ],
        providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }],
        bootstrap: [AppComponent]
    })
], AppModule);
export { AppModule };
//# sourceMappingURL=app.module.js.map