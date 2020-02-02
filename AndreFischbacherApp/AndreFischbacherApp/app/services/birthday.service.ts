import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { About } from '../models/about';

@Injectable()
export class AgeService {

    constructor() { }

    public getCurrentAge(): string {
        return Math.floor((new Date().getTime() - new Date("1995-08-18 1:00").getTime()) / 1000 / 60 / 60 / 24 / 365).toString();
    }
}