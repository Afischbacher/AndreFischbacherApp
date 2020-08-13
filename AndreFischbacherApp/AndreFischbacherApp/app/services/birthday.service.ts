import { Injectable } from '@angular/core';
import * as moment from 'moment'; 

@Injectable()
export class AgeService {

    constructor() { }

    public getCurrentAge(): number {        
        
        let birthDate = moment("1995-08-18");
        let timeNow = moment();
        let ageInYears = moment.duration(timeNow.diff(birthDate)).asYears().toString();
        
        return parseInt(ageInYears); 
    }
}