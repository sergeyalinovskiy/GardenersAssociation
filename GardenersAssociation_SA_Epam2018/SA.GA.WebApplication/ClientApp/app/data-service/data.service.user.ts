import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../models/user';
import { Plot } from '../models/plot';
import { Electricity } from '../models/electricity';
import { Rate } from '../models/rate';
import { History } from '../models/history';

@Injectable()
export class DataServiceUser {

    private urlUser = "/api/users";
    
    constructor(private http: HttpClient) {
    }

    getUsers() {
        return this.http.get(this.urlUser);
    }

    getActiveUsers() {
        return this.http.get('/' + 'getActiveUsers');
    }

    getNotActiveUsers() {
        return this.http.get('/' + 'getNotActiveUsers');
    }

    getUser(id: number) {
        return this.http.get(this.urlUser + '/' + id);
    }

    createUser(user: User) {
        return this.http.post(this.urlUser, user);
    }

    updateUser(user: User) {
        return this.http.put(this.urlUser + '/' + user.id, user);
    }

    deleteUser(id: number) {
        return this.http.delete(this.urlUser + '/' + id);
    }

    getUserPlots(id: number) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    }

    getPlotElectricity(id: number) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    }
}