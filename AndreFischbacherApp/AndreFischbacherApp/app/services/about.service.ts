import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { About } from '../models/about';
import { environment } from 'AndreFischbacherApp/environments/environment';

@Injectable()
export class AboutService {

    constructor(private httpClient: HttpClient) { }

    public getAboutInformation(): Observable<About[]> {
        return this.httpClient.get<About[]>(`${environment.api}/v1/about`);
    }
}