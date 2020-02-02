import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatDialogModule } from '@angular/material';
import { AppInfoDialog } from './app-info-dialog.component.';

@NgModule({
    declarations: [
        AppInfoDialog
    ],
    imports: [
        CommonModule,
        MatDialogModule
    ],
    exports: [AppInfoDialog]
})

export class AppInfoDialogModule { }
