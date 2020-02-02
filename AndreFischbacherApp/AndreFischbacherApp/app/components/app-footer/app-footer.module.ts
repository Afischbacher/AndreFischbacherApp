import { NgModule } from '@angular/core';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule, MatButtonModule, MatDialogModule, MatRippleModule } from '@angular/material';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule } from '@angular/router';
import { AppFooter } from './app-footer.component';
import { AppInfoDialog } from '../app-info-dialog/app-info-dialog.component.';

@NgModule({
    declarations: [
        AppFooter
    ],
    imports: [
        MatIconModule,
        RouterModule,
        MatRippleModule,
        MatTooltipModule,
        MatToolbarModule,
        MatDialogModule,
        MatButtonModule
    ],
    entryComponents: [AppInfoDialog],
    providers: [],
    exports: [AppFooter]
})
export class AppFooterModule { }
