import {Component, Inject} from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

@Component({
    selector: "app-info-dialog",
    templateUrl: "./app-info-dialog.component.html",
    styleUrls: ["./app-info-dialog.scss"]
})
export class AppInfoDialog {

    constructor(public dialogRef: MatDialogRef<AppInfoDialog>, @Inject(MAT_DIALOG_DATA) public data: any) {
        
    }

    onClose(): void {
        this.dialogRef.close();
    }

}