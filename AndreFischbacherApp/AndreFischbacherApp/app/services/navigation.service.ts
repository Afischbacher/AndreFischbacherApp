import { Injectable } from '@angular/core';

@Injectable()
export class NavigationService {

    public vibrate(pattern: number[]) : void {
        if ("vibrate" in navigator) { 
            window.navigator.vibrate(pattern);
        }
    }

}