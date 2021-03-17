import axios from 'axios'

axios.defaults.baseURL = 'http://localhost:5000/api'

const responseBody = (response)=>response.data;
const requests = {
    get: (url)=>axios.get(url).then(responseBody)
}

const Results = (url, keyword)=>requests.get(`/SearchEngine?url=${url}&keyword=${keyword}`)

const result={
    Results
}

export default result;