import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/user';
import { Plot } from '../models/plot';
import { Electricity } from '../models/electricity';
import { Rate } from '../models/rate';
import { History } from '../models/history';

@Injectable()
export class DataServiceRate {

    private urlRate = "/api/rates";

    constructor(private http: HttpClient) {
    }

    getUserPlots(id: number) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    }

    getPlotElectricity(id: number) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    }

    getRates() {
        return this.http.get(this.urlRate);
    }

    getRate(id: number) {
        return this.http.get(this.urlRate + '/' + id);
    }

    createRate(rate: Rate) {
        return this.http.post(this.urlRate, rate);
    }

    updateRate(rate: Rate) {
        return this.http.put(this.urlRate + '/' + rate.id, rate);
    }

    deleteRate(id: number) {
        return this.http.delete(this.urlRate + '/' + id);
    }

    getRateInfo(id: number) {
        return this.http.get('/api/electricitys' + '/' + 'GetRateInfo' + '/' + id);
    }
}