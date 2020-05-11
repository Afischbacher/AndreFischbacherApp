import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialogModule } from '@angular/material/dialog';
import { AppInfoDialog } from './app-info-dialog.component.';

@NgModule({
    declarations: [
        AppInfoDialog
    ], 
    imports: [
        CommonModule,
        MatDialogModule
    ],
    providers: [],
    exports: [AppInfoDialog]
})

export class AppInfoDialogModule { }
