import { NgModule } from '@angular/core';
import { AppToolbar } from './toolbar.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule } from '@angular/router';

@NgModule({
    declarations: [
        AppToolbar
    ],
    imports: [
        MatIconModule,
        RouterModule,
        MatTooltipModule,
        MatToolbarModule
    ],
    providers: [],
    exports: [AppToolbar]
})
export class AppToolbarModule { }
