import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/user';
import { Plot } from '../models/plot';
import { Electricity } from '../models/electricity';
import { Rate } from '../models/rate';
import { History } from '../models/history';

@Injectable()
export class DataServiceElectricity {

    private urlElectricity = "/api/electricitys";
    

    constructor(private http: HttpClient) {
    }

    getElectricitys() {
        return this.http.get(this.urlElectricity);
    }

    getElectricity(id: number) {
        return this.http.get(this.urlElectricity + '/' + id);
    }

    createElectricity(electricity: Electricity) {
        return this.http.post(this.urlElectricity, electricity);
    }

    updateElectricity(electricity: Electricity) {
        return this.http.put(this.urlElectricity + '/' + electricity.id, electricity);
    }

    deleteElectricity(id: number) {
        return this.http.delete(this.urlElectricity + '/' + id);
    }

    getRateInfo(id: number) {
        return this.http.get('/api/electricitys' + '/' + 'GetRateInfo' + '/' + id);
    }


    getUserPlots(id: number) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    }

    getPlotElectricity(id: number) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    }
}