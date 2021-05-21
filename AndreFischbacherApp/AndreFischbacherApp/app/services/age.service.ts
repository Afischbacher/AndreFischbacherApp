import { Injectable } from '@angular/core';
import * as moment from 'moment'; 

@Injectable()
export class AgeService {

    constructor() { }
    public getCurrentAge(): number {        
        const birthDateTime = "1995-08-18";

        const birthDate = moment(birthDateTime);
        const timeNow = moment();
        const ageInYears = moment.duration(timeNow.diff(birthDate)).asYears().toString();
        
        return parseInt(ageInYears); 
    }
}