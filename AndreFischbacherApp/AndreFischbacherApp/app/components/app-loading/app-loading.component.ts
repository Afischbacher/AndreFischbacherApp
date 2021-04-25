import { Component } from '@angular/core';
import { Input} from '@angular/core';
import { faExclamationCircle } from '@fortawesome/free-solid-svg-icons';

export enum LoadingStatus {
    Loading,
    Loaded,
    Failed
}

@Component({
    selector: "app-loading",
    templateUrl: "./app-loading.component.html",
    styleUrls: ["./app-loading.scss"]
})
export class AppLoading {

    public color = 'primary';
    public mode = 'indeterminate';
    public faExclamationCircle = faExclamationCircle;

    public LoadingStatus : typeof LoadingStatus = LoadingStatus;
    @Input('loadingStatus') loadingStatus: LoadingStatus;

    constructor() {   }

}