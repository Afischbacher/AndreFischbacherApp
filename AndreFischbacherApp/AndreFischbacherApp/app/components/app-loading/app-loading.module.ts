import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { AppLoading } from './app-loading.component';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
    declarations: [
        AppLoading
    ], 
    imports: [
        CommonModule,
        FontAwesomeModule,
        MatProgressSpinnerModule
    ],
    providers: [],
    exports: [AppLoading]
})
export class AppLoadingModule { }
