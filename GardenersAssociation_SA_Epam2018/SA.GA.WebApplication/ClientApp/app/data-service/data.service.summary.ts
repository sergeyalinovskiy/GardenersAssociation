import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Summary } from '../models/summary';

@Injectable()
export class DataServiceSummary {

    private urlSummary = "api/summary";

    constructor(private http: HttpClient) {
    }

    getSummary() {
        return this.http.get(this.urlSummary);
    }

    createSummary(summary: Summary) {
        return this.http.post(this.urlSummary, summary);
    }
}
