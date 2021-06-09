import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Interests } from '../models/interests';
import { environment } from 'AndreFischbacherApp/environments/environment';

@Injectable()
export class InterestsService {

    constructor(private httpClient: HttpClient){}

    public getInterestsInformation() : Observable<Interests[]> {
        return this.httpClient.get<Interests[]>(`${environment.api}/v1/interests`);
    }
}