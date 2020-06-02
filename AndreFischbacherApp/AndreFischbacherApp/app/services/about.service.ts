import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { About } from '../models/about';

@Injectable()
export class AboutService {

    constructor(private httpClient: HttpClient) { }

    public getAboutInformation(): Observable<About[]> {
        return this.httpClient.get<About[]>(`https://andrefischbacherappfunctions.azurewebsites.net/v1/about`);
    }
}