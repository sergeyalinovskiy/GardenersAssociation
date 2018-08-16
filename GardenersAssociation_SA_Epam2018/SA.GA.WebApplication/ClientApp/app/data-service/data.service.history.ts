import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/user';
import { Plot } from '../models/plot';
import { Electricity } from '../models/electricity';
import { Rate } from '../models/rate';
import { History } from '../models/history';

@Injectable()
export class DataServiceHistory {

    private urlHistory = "/api/history";   

    constructor(private http: HttpClient) {
    }

    getUserPlots(id: number) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    }

    getPlotElectricity(id: number) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    }

    getHistorys() {
        return this.http.get(this.urlHistory);
    }

    getHistory(id: number) {
        return this.http.get(this.urlHistory + '/' + id);
    }

    createHistory(history: History) {
        return this.http.post(this.urlHistory, history);
    }

    updateHistory(history: History) {
        return this.http.put(this.urlHistory + '/' + history.id, history);
    }

    deleteHistory(id: number) {
        return this.http.delete(this.urlHistory + '/' + id);
    }
}