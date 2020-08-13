import { Injectable } from '@angular/core';
import * as moment from 'moment'; 

@Injectable()
export class AgeService {

    constructor() { }

    public getCurrentAge(): number {        
        
        let birthdayDate = moment("1995-08-18");
        let now = moment();
        let ageInYears = moment.duration(now.diff(birthdayDate)).asYears().toString();
        
        return parseInt(ageInYears); 
    }
}