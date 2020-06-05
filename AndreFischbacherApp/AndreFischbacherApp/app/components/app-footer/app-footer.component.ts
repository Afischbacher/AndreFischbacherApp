import {Component} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { AppInfoDialog } from '../app-info-dialog/app-info-dialog.component.';


@Component({
    selector: "app-footer",
    templateUrl: "./app-footer.component.html",
    styleUrls: ["./app-footer.scss"]
})
export class AppFooter {
    
    constructor(public appInfoDialog: MatDialog){

    }

    openAppInfoDialog(){
        this.appInfoDialog.open(AppInfoDialog,{
            width: '500px',
            closeOnNavigation: true,
            data: {} // no data at the moment
        })
    }

}