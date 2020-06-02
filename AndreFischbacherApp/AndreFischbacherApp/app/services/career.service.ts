import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Career } from '../models/career';

@Injectable()
export class CareerService {

    constructor(private httpClient: HttpClient){}

    public getCareerInformation() : Observable<Career[]> {
        return this.httpClient.get<Career[]>(`https://andrefischbacherappfunctions.azurewebsites.net/v1/career`);
    }
}