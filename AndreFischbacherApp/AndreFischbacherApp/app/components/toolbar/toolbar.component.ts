import {Component} from '@angular/core';
import { TooltipPosition } from '@angular/material/tooltip';
import { NavigationService } from '../../services/navigation.service';

@Component({
    selector: "app-toolbar",
    templateUrl: "./toolbar.component.html",
    styleUrls: ["./toolbar.scss"]
})
export class AppToolbar {
    positionOptions: TooltipPosition[] = ['below'];

    constructor(private navigationService: NavigationService){

    }

    public goHome(){
        this.navigationService.vibrate([25]);
    }
}